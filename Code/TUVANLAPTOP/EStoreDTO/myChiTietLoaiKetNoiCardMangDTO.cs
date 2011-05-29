using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietLoaiKetNoiCardMangDTO
    {
        string m_sTenLoaiKetNoiCardMang;

        public string STenLoaiKetNoiCardMang
        {
            get { return m_sTenLoaiKetNoiCardMang; }
            set { m_sTenLoaiKetNoiCardMang = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return m_fHeSo; }
            set { m_fHeSo = value; }
        }
    }
}
