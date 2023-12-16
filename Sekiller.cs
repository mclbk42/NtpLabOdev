using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtpLabOdev5
{
    public class Sekiller
    {

        protected char sembol;
        protected bool doluMu;
        public string olusturulmaTarihi;

        // Parametresiz yapılandırıcı
        public Sekiller()
        {
            sembol = '*';
            doluMu = true;
            olusturulmaTarihi = DateTime.Now.ToString();
        }

        // Parametreli yapılandırıcı (sembol parametresi alır)
        public Sekiller(char sembol)
        {
            this.sembol = sembol;

        }

        // Parametreli yapılandırıcı (sembol ve doluMu parametreleri alır)
        public Sekiller(char sembol, bool doluMu)
        {
            this.sembol = sembol;
            this.doluMu = doluMu;

        }

        // Sembol özelliğini ayarlayan yöntem
        public void SetSembol(char sembol)
        {
            this.sembol = sembol;
        }

        // DoluMu özelliğini ayarlayan yöntem
        public void SetDoluMu(bool doluMu)
        {
            this.doluMu = doluMu;
        }

        // DoluMu özelliğini döndüren yöntem
        public bool GetDoluMu()
        {
            return this.doluMu;
        }

        // Oluşturulma tarihini döndüren yöntem
        public string GetOlusturulmaTarihi()
        {
            return this.olusturulmaTarihi;
        }
    }
}

