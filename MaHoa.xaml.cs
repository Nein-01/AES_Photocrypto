using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Drawing;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.Drawing.Imaging;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MaHoa.xaml
    /// </summary>
    public partial class MaHoa : Window
    {
        private string inPath1=""; //duong dan toi file anh can giau
        private string inPathTxt = ""; //duong dan toi file txt

        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        private int BlockSize = 128;
        /*private SymmetricAlgorithm encrypt = Aes.Create();
        private SymmetricAlgorithm decrypt = Aes.Create();*/
        private HashAlgorithm hash = MD5.Create();
        public MaHoa()
        {
            InitializeComponent();
            WindowStartupLocation= WindowStartupLocation.CenterScreen;
            lbAnhGiauTin.Visibility = Visibility.Hidden;
        }

        private void ChonAnh(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); // tạo biến lấy ảnh

            openFileDialog1.ShowDialog();  // mở giao diện chọn ảnh
            inPath1 = openFileDialog1.FileName; // lấy ra đường dẫn của file vừa mở
            if (inPath1 != "")
            {
                // hiển  thị ảnh
                AnhGoc.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(inPath1, UriKind.Relative)));  
            }
        }
        //hàm mã hóa
        private void btMaHoa(object sender, RoutedEventArgs e)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(ThongDiep.Text);

            //Encrypt
            SymmetricAlgorithm encrypt = Aes.Create();            
            encrypt.BlockSize = BlockSize;
            encrypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(Khoa.Text));
            encrypt.IV = IV;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encrypt.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(bytes, 0, bytes.Length);
                }

                ThongDiepMaHoa.Text = Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        //hàm giấu tin
        private void GiauTin(object sender, RoutedEventArgs e)
        {
            Bitmap img = new Bitmap(inPath1);
            xamhoa(img);
            int i, j;
            for (i = 0; i < img.Width; i++)
            {
                for (j = 0; j < img.Height; j++)
                {
                    System.Drawing.Color pixel = img.GetPixel(i, j);
                    if (i < 1 && j < ThongDiepMaHoa.Text.Length)
                    {
                        Console.WriteLine("R[" + i + "][" + j + "] : " + pixel.R);
                        Console.WriteLine("R[" + i + "][" + j + "] : " + pixel.B);
                        Console.WriteLine("R[" + i + "][" + j + "] : " + pixel.G);
                        char letter = Convert.ToChar(ThongDiepMaHoa.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        Console.WriteLine("Letter: " + letter + "\n Value: " + value);
                        img.SetPixel(i, j, System.Drawing.Color.FromArgb(pixel.R, pixel.G, value));
                    }
                    if (i == img.Width - 1 && j == img.Height - 1)
                    {
                        img.SetPixel(i, j, System.Drawing.Color.FromArgb(pixel.R, pixel.G, ThongDiepMaHoa.Text.Length));
                    }
                }
            }
            //Luu lai anh da giau tin
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "BMP|*.bmp|JPG|*.jpg|PNG|*.png";
            savefile.ShowDialog();
            string filename = savefile.FileName;
            img.Save(filename);
            //Hien thi anh giau tin
            inPath1 = filename;
            AnhGiauTin.Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(inPath1, UriKind.Relative)));
            lbAnhGiauTin.Visibility = Visibility.Visible;
        }
        public static void xamhoa(Bitmap b)
        {
            System.Drawing.Rectangle rec = new System.Drawing.Rectangle(0, 0, b.Width, b.Height);
            BitmapData bdata = b.LockBits(rec, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            int stride = bdata.Stride;
            int nOffset = stride - b.Width * 3;
            IntPtr ptr = bdata.Scan0;
            unsafe
            {
                byte* p = (byte*)ptr;
                int x, y, red, green, blue, xam;
                for (y = 0; y < b.Height; y++)
                {
                    for (x = 0; x < b.Width; x++)
                    {
                        blue = p[0];

                        green = p[1];

                        red = p[2];

                        xam = (int)(red * 0.287 + green * 0.559 + blue * 0.114);
                        p[0] = (byte)(xam);
                        p[1] = (byte)(xam);
                        p[2] = (byte)(xam);

                        p += 3;
                    }
                    p += nOffset;
                }
            }

            b.UnlockBits(bdata);

        }
        //hàm lấy tin từ ảnh
        private void LayThongDiep(object sender, RoutedEventArgs e)
        {
            if (inPath1 == "")
            {
                MessageBox.Show("Chưa có ảnh để lấy thông điệp", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Bitmap img = new Bitmap(inPath1);
                string message = "";
                System.Drawing.Color lpixel = img.GetPixel(img.Width - 1, img.Height - 1);
                int messlen = lpixel.B;
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        System.Drawing.Color pixel = img.GetPixel(i, j);
                        if (i < 1 && j < messlen)
                        {
                            Console.WriteLine("-------------");
                            Console.WriteLine("R[" + i + "][" + j + "] : " + pixel.R);
                            Console.WriteLine("R[" + i + "][" + j + "] : " + pixel.B);
                            Console.WriteLine("R[" + i + "][" + j + "] : " + pixel.G);

                            int value = pixel.B;
                            Console.WriteLine("Value: " + value);
                            char c = Convert.ToChar(value);

                            string letter = c.ToString();
                            message = message + letter;
                        }
                    }
                }
                ThongDiep.Text = message;

            }
        }
        //hàm giải mã
        private void btGiaiMa(object sender, RoutedEventArgs e)
        {
            //Decrypt
            byte[] bytes = Convert.FromBase64String(ThongDiep.Text);
            SymmetricAlgorithm decrypt = Aes.Create();           
            decrypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(Khoa.Text));
            decrypt.IV = IV;

            try
            {
                using (MemoryStream memoryStream = new MemoryStream(bytes))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decrypt.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        byte[] decryptedBytes = new byte[bytes.Length];
                        cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                        ThongDiepSauGiaiMa.Text = Encoding.Unicode.GetString(decryptedBytes);
                    }
            
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Mật khẩu không đúng, hãy nhập lại!", "Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void LamMoi(object sender, RoutedEventArgs e)
        {
            ThongDiep.Text = "";
            Khoa.Text = "";
            ThongDiepMaHoa.Text = "";
            ThongDiepSauGiaiMa.Text = "";
            lbAnhGiauTin.Visibility = Visibility.Hidden;
            AnhGiauTin.Source = null;
            AnhGoc.Source = null;
        }

        private void btLayTxt(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); 
            openFileDialog.ShowDialog();  
            inPathTxt = openFileDialog.FileName;
            if (inPathTxt != "")
            {
                string txtMaHoa = File.ReadAllText(inPathTxt);
                ThongDiep.Text = txtMaHoa;
            }
        }

        private void btCatTxt(object sender, RoutedEventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "TXT|*.txt|DOCX|*.docx";
            savefile.ShowDialog();
            string fileTxt = savefile.FileName;
            string txtMaHoa = ThongDiepMaHoa.Text;
            File.WriteAllText(fileTxt, txtMaHoa);
        }
    }
}
