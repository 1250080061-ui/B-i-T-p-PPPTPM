namespace QuanLyKhachSan.Services
{
    public class KetQuaXuLy
    {
        public bool ThanhCong { get; set; }
        public string ThongBao { get; set; }

        public static KetQuaXuLy Ok(string thongBao)
        {
            return new KetQuaXuLy
            {
                ThanhCong = true,
                ThongBao = thongBao
            };
        }

        public static KetQuaXuLy Fail(string thongBao)
        {
            return new KetQuaXuLy
            {
                ThanhCong = false,
                ThongBao = thongBao
            };
        }
    }

    public class PhongDatItem
    {
        public string SoPhong { get; set; }
        public int SoNguoi { get; set; }
        public decimal DonGiaNgay { get; set; }
    }

    public class DenBuItem
    {
        public string MaTienNghi { get; set; }
        public string TenLoaiTN { get; set; }
        public string MucDoThietHai { get; set; }
        public decimal SoTien { get; set; }
    }
}