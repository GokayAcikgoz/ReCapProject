using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string BrandInvalid = "Marka ekleme başarısız";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandGetAll = "Marka listelendi";
        public static string BrandGetById = "numaralı marka listelendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";

        public static string CarInvalid = "Araç ekleme başarısız";
        public static string CarAdded = "Araç eklendi";
        public static string CarGetAll = "Araç listelendi";
        public static string CarGetById = "numaralı araç listelendi";
        public static string CarUpdated = "Araç güncellendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarDetail = "Araç detayları getirildi";

        public static string ColorInvalid = "Renk ekleme başarısız";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorGetAll = "Renk listelendi";
        public static string ColorGetById = "numaralı renk listelendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserGetAll = "Kullanıcı listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerGetAll = "Müşteri listelendi";

        public static string RentalAdded = "Araç kiralama eklendi";
        public static string RentalInvalid = "Araç kiralama başarısız";
        public static string RentalUpdated = "Araç kiralama güncellendi";
        public static string RentalDeleted = "Araç kiralama silindi";
        public static string RentalGetAll = "Kiralanan araçlar listelendi";

        public static string ImageAdded = "Resim eklendi";
        public static string ImageDeleted = "Resim silindi";
        public static string ImageUpdated = "Resim güncellendi";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
