using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Barcode;

namespace InjectionMold_TrackingSystem.UtilityClass
{
    public class QRData
    {
        public string Partnumber { get; set; }
        public string Partname { get; set; }
        public string DieNumber { get; set; }
        public string MoldNumber { get; set; }
        public string Customer { get; set; }
        public string MachineNumber { get; set; }
        public string MachineName { get; set; }

        public QRData(string QRData)
        {
            MoldParsedData(QRData);
        }
        private void MoldParsedData(string QRData)
        {
            var dataParts = QRData.Split('/');

            if (dataParts.Length == 4)
            {
                Partnumber = dataParts[0];
                MoldNumber = dataParts[1];
                DieNumber = dataParts[2];
                Customer = dataParts[3];
            }
            else if (dataParts.Length == 2)
            {
                MachineNumber = dataParts[0];
                MachineName = dataParts[1];
            }      
        }
       
    }
    public class ScannedDataUtility
    {
        public Image GenerateQrCode(string QrData)
        {
            BarcodeDraw qrCodeDraw = BarcodeDrawFactory.CodeQr;
            Image qrCodeImage = qrCodeDraw.Draw(QrData, 100);

            return qrCodeImage;
        }
    }
}
