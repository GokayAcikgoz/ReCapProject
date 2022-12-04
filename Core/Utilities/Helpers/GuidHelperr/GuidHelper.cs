using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.GuidHelperr
{
    public class GuidHelper
    {
        public static string CreateGuid()
        {
            return Guid.NewGuid().ToString(); //image dosyasına yeni bir isim oluşturmak için. Her resim yükleme işleminde otomatik olarak isim üretecek.
                                                //Buda her resim için benzersiz isim demek.
        }
    }
}
