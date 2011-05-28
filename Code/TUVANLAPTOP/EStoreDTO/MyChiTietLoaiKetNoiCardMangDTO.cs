using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietLoaiKetNoiCardMangDTO
    {
        string m_sTenLoaiKetNoiCardMang;

        public string STenLoaiKetNoiCardMang
        {
            get { return this.m_sTenLoaiKetNoiCardMang; }
            set { this.m_sTenLoaiKetNoiCardMang = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return this.m_fHeSo; }
            set { this.m_fHeSo = value; }
        }
    }
}
