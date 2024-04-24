using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAO nhaCungCapDAO = new NhaCungCapDAO();

        public List<NhaCungCap> LayDanhSachNhaCungCap()
        {
            return nhaCungCapDAO.LayToanBoNhaCungCap();
        }


        public bool ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            foreach (var item in nhaCungCapDAO.LayToanBoNhaCungCap())
            {
                if (item.TenNhaCungCap == nhaCungCap.TenNhaCungCap && item.TrangThai == 1)
                {
                    return false;
                }
            }
            return nhaCungCapDAO.ThemNhaCungCap(nhaCungCap);
        }

        public bool SuaNhaCungCap(NhaCungCap nhaCungCap)
        {
            foreach (var item in nhaCungCapDAO.LayToanBoNhaCungCap())
            {
                if (item.TenNhaCungCap == nhaCungCap.TenNhaCungCap && item.TrangThai == 0)
                {
                    return false;
                }
            }
            return nhaCungCapDAO.SuaNhaCungCap(nhaCungCap);
        }

        public bool XoaNhaCungCap(int maNhaCungCap)
        {
            return nhaCungCapDAO.XoaNhaCungCap(maNhaCungCap);
        }

        public NhaCungCap LayNhaCungCapQuaMa(int maNhaCungCap)
        {
            foreach (NhaCungCap nhaCungCap in nhaCungCapDAO.LayToanBoNhaCungCap())
            {
                if (nhaCungCap.MaNhaCungCap == maNhaCungCap)
                {
                    if (nhaCungCap.TrangThai == 1)
                    {
                        return nhaCungCap;
                    }
                    else
                    {
                        return nhaCungCap;
                    }
                }
            }
            return null;
        }

        public NhaCungCap LayNhaCungCapQuaTen(string tenNhaCungCap)
        {
            foreach (NhaCungCap nhaCungCap in nhaCungCapDAO.LayToanBoNhaCungCap())
            {
                if (nhaCungCap.TenNhaCungCap == tenNhaCungCap)
                {
                    if (nhaCungCap.TrangThai == 1)
                    {
                        return nhaCungCap;
                    }
                    else
                    {
                        return nhaCungCap;
                    }
                }
            }
            return null;
        }

        public List<NhaCungCap> TimKiemNhaCungCap(string text)
        {
            return nhaCungCapDAO.TimKiemNhaCungCap(text);
        }
    }
}
