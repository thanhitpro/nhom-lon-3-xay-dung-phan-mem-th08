using System;
using System.Collections.Generic;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietBoNhoCardDoHoaDAO
    {
        private DataClasses1DataContext storeDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lấy ds Bộ Nhớ Card MH
        /// </summary>
        /// <returns>
        ///     Nếu không xuất hiện lỗi trả về danh sách chi tiết bộ nhớ Card đồ họa. 
        ///     Nếu có lỗi throw một exception.
        ///</returns>
        public List<myChiTietBoNhoCardDoHoaDTO> LayDSBoNhoMH()
        {
            try
            {
                List<myChiTietBoNhoCardDoHoaDTO> listBoNhoCardMH = new List<myChiTietBoNhoCardDoHoaDTO>();
                foreach (CHITIETBONHOCARDDOHOA chitTietBoNhoCardDoHoa in storeDataContext.CHITIETBONHOCARDDOHOAs)
                {
                    myChiTietBoNhoCardDoHoaDTO myChiTietBoNhoCardDoHoaDTO = new myChiTietBoNhoCardDoHoaDTO();
                    myChiTietBoNhoCardDoHoaDTO.STenChiTietCardDoHoa = chitTietBoNhoCardDoHoa.TenChiTietBoNhoCardDoHoa;
                    myChiTietBoNhoCardDoHoaDTO.FHeSo = (float)chitTietBoNhoCardDoHoa.HeSo;

                    listBoNhoCardMH.Add(myChiTietBoNhoCardDoHoaDTO);
                }

                return listBoNhoCardMH;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm bộ nhớ Card MH:
        /// </summary>
        /// <param name="_mBoNhoCardMH">Đối tượng ChiTietBoNhoCarDoHoaDTO cần thêm</param>
        /// <returns>
        ///     Nếu thành công trả về true
        ///     Nếu có lỗi throw một Exception
        /// </returns>
        public bool ThemBoNhoCardMH(myChiTietBoNhoCardDoHoaDTO myChiTietBoNhoCardCardDoHoaDTO)
        {
            try
            {
                CHITIETBONHOCARDDOHOA chiTietBoNhoCardDoHoa = new CHITIETBONHOCARDDOHOA();
                chiTietBoNhoCardDoHoa.TenChiTietBoNhoCardDoHoa = myChiTietBoNhoCardCardDoHoaDTO.STenChiTietCardDoHoa;
                chiTietBoNhoCardDoHoa.HeSo = (float)myChiTietBoNhoCardCardDoHoaDTO.FHeSo;

                storeDataContext.CHITIETBONHOCARDDOHOAs.InsertOnSubmit(chiTietBoNhoCardDoHoa);
                storeDataContext.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Thêm mới card màn hình thất bại !", ex);
            }
        }
    }
}
