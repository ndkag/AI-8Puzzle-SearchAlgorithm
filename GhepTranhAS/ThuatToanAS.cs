using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhepTranhAS
{



    public class Node //đại diện cho các nút trong cây tìm kiếm, mỗi nút chưa thông tin 
    {

        public int[,] MaTran;// ma trận 8 số
        public int SoManhSai;//số mảnh sai vị trí của ma trận
        public int ChiSo;// chỉ số của node
        public int Cha;// cha của node, để truy vét kết quả
        public int g;// chi phí đi đến node đó
    }
    class ThuatToanAS
    {
        private int ChiSo = 0;//chỉ số của Node sẽ tăng sau mỗi lần sinh ra 1 node
        private int g = 0;// Sau mỗi lần sinh ra các node thì chi phí các node tăng 1 đơn vị,
                          // tức node con sẽ có chi phí lớn hơn node cha 1 đơn vị

        int soMiengSaiViTri(int[,] MaTran)
        //tính số mảnh sai vị trí trong ma trận 8 số
        {
            int dung = 0;



            if (MaTran[0, 0] == 1)
                dung++;
            if (MaTran[0, 1] == 2)
                dung++;
            if (MaTran[0, 2] == 3)
                dung++;
            if (MaTran[1, 0] == 4)
                dung++;
            if (MaTran[1, 1] == 5)
                dung++;
            if (MaTran[1, 2] == 6)
                dung++;
            if (MaTran[2, 0] == 7)
                dung++;
            if (MaTran[2, 1] == 8)
                dung++;


            return 8 - dung;
        }

        public Stack<int[,]> timKetQua(int[,] MaTran, int n)
        //phương thức thức chính của A*
        {

            Stack<int[,]> stkKetQua = new Stack<int[,]>();
            //khởi tạo danh sách
            List<Node> Open = new List<Node>();//lưu các nút có thể được duyệt
            List<Node> Close = new List<Node>();//lưu các nút đã được duyệt


            //khai báo và khởi tạo cho node đầu tiên
            Node tSo = new Node();
            tSo.MaTran = MaTran;
            tSo.SoManhSai = soMiengSaiViTri(MaTran);
            tSo.ChiSo = 0;
            tSo.Cha = -1;
            tSo.g = 0;
            //cho trạng thái đầu tiên vào Open;
            Open.Add(tSo);

            int u = 0;
            while (Open.Count != 0)
            {
                #region chọn node tốt nhất trong tập Open và chuyển nó sang Close
                tSo = new Node();
                tSo = Open[u];
                Open.Remove(tSo);
                Close.Add(tSo);
                #endregion

                //nếu node có số mảnh sai là 0, tức là đích thì thoát
                if (tSo.SoManhSai == 0) break;
                else
                {
                    //sinh hướng đi của node hiện tại
                    List<Node> lstHuongDi = new List<Node>();
                    lstHuongDi = sinhHuongDi(tSo);

                    for (int i = 0; i < lstHuongDi.Count; i++)
                    {
                        //hướng đi không thuộc Open và Close
                        if (!haiNodeTrungNhau(lstHuongDi[i], Open) && !haiNodeTrungNhau(lstHuongDi[i], Close))
                        {
                            Open.Add(lstHuongDi[i]);
                        }
                        else
                        {   //nếu hướng đi thuộc Open
                            if (haiNodeTrungNhau(lstHuongDi[i], Open))
                            {
                                /*nếu hướng đi đó tốt hơn thì sẽ được cập nhật lại, 
                                ngược lại thì sẽ không cập nhật*/
                                soSanhTotHon(lstHuongDi[i], Open);
                            }
                            else
                            {
                                //nếu hướng đi thuộc Close
                                if (haiNodeTrungNhau(lstHuongDi[i], Close))
                                {
                                    //nếu hướng đi đó tốt hơn thì sẽ được cập nhật lại, 
                                    //ngược lại thì sẽ không cập nhật và chuyển từ Close sang Open//
                                    if (soSanhTotHon(lstHuongDi[i], Close))
                                    {
                                        Node temp = new Node();
                                        temp = layNodeTrungTrongClose(lstHuongDi[i], Close);
                                        Close.Remove(temp);
                                        Open.Add(temp);
                                    }
                                }
                            }
                        }

                    }

                    //chọn vị trí có phí tốt nhất trong Open
                    u = viTriTotNhatOpen(Open);
                }

            }

            //truy vét kết quả trong tập Close
            stkKetQua = truyVetKetQua(Close);

            return stkKetQua;
        }

        //truy vét kết quả đường đi trong tập Close
        Stack<int[,]> truyVetKetQua(List<Node> Close)
        /*sau khi dùng phương thức  truy vét kết quả, xđ đường đi từ nút đích về nút ban đầu
        và lưu trữ nó trong 1 Stack và trả về đường đi theo thứ tự đúng*/
        {
            Stack<int[,]> ketQua = new Stack<int[,]>();

            int t = Close[Close.Count - 1].Cha;
            Node temp = new Node();
            ketQua.Push(Close[Close.Count - 1].MaTran);
            Debug.WriteLine("$$$ Vét kết Quả");

            while (t != -1)
            {
                for (int i = 0; i < Close.Count; i++)
                {
                    if (t == Close[i].ChiSo)
                    {
                        temp = Close[i];
                        break;
                    }
                }

                ketQua.Push(temp.MaTran);
                Debug.WriteLine(BoardToString(temp.MaTran));
                t = temp.Cha;
            }

            return ketQua;

        }


        /// <summary>
        /// hàm sinh ra các hướng đi từ một node sinh ra các node con
        /// </summary>
        /// <param name="ThamSo">node Cha</param>
        /// <returns>danh sách các hướng đi</returns>
        List<Node> sinhHuongDi(Node tSo)//pthuc quan trọng của A*
                                        //phương thức để tạo ra list các hướng đi
        {
            int n = tSo.MaTran.GetLength(0);//lấy số hàng của ma trận

            List<Node> lstHuongDi = new List<Node>();//list chứa các trạng thái con sẽ được trả về

            //  Xác định vị trí mảnh chống, có giá trị là 0 trong matrix
            int h = 0;
            int c = 0;
            bool ok = false;
            for (h = 0; h < n; h++)
            {
                for (c = 0; c < n; c++)
                    if (tSo.MaTran[h, c] == 0)//duyệt từng hàng và cột cho đến khi tìm thấy ô trống (gtri = 0)
                    {
                        ok = true;
                        break;
                    }

                if (ok) break;//biến ok dùng để đánh dấu thoát khỏi for khi đã seen thấy vị trí ô trống
            }


            Node Temp = new Node();//tạo 1 trạng thái tạm thời Temp 
            Temp.MaTran = new int[n, n];
            //Copy mảng Ma trận (cha (TSo)) sang mảng ma trận tạm Temp
            Array.Copy(tSo.MaTran, Temp.MaTran, tSo.MaTran.Length);

            g++;// tăng chi phí của node con lên 1 đơn vị

            #region Xét các hướng đi theo 4 hướng: trên, dưới, phải, trái 
            //xét hàng ngang bắt đầu từ hàng thứ 2 trở đi
            if (h > 0 && h <= n - 1)
            {
                // thay đổi hướng đi của ma trận
                Temp.MaTran[h, c] = Temp.MaTran[h - 1, c];
                Temp.MaTran[h - 1, c] = 0;

                //cập nhật lại thông số của node
                Temp.SoManhSai = soMiengSaiViTri(Temp.MaTran);
                ChiSo++;
                Temp.ChiSo = ChiSo;
                Temp.Cha = tSo.ChiSo;
                Temp.g = g + Temp.SoManhSai;
                lstHuongDi.Add(Temp);

                //sau khi thay đổi ma trận thì copy lại ma trận cha cho MaTran để xét trường hợp tiếp theo
                Temp = new Node();
                Temp.MaTran = new int[n, n];
                Array.Copy(tSo.MaTran, Temp.MaTran, tSo.MaTran.Length);
            }
            //xét hàng ngang bắt đầu từ hàng thứ cuối cùng - 1 trở xuống
            if (h < n - 1 && h >= 0)
            {
                // thay đổi hướng đi của ma trận
                Temp.MaTran[h, c] = Temp.MaTran[h + 1, c];
                Temp.MaTran[h + 1, c] = 0;

                //cập nhật lại thông số của node
                Temp.SoManhSai = soMiengSaiViTri(Temp.MaTran);
                ChiSo++;
                Temp.ChiSo = ChiSo;
                Temp.Cha = tSo.ChiSo;
                Temp.g = g + Temp.SoManhSai;
                lstHuongDi.Add(Temp);

                //sau khi thay đổi ma trận thì copy lại ma trận cha cho MaTran để xét trường hợp tiếp theo
                Temp = new Node();
                Temp.MaTran = new int[n, n];
                Array.Copy(tSo.MaTran, Temp.MaTran, tSo.MaTran.Length);
            }
            //Xét cột dọc bắt đầu từ cột thứ 2 trở đi
            if (c > 0 && c <= n - 1)
            {
                // thay đổi hướng đi của ma trận
                Temp.MaTran[h, c] = Temp.MaTran[h, c - 1];
                Temp.MaTran[h, c - 1] = 0;

                //cập nhật lại thông số của node
                Temp.SoManhSai = soMiengSaiViTri(Temp.MaTran);
                ChiSo++;
                Temp.ChiSo = ChiSo;
                Temp.Cha = tSo.ChiSo;
                Temp.g = g + Temp.SoManhSai;
                lstHuongDi.Add(Temp);

                //sau khi thay đổi ma trận thì copy lại ma trận cha cho MaTran để xét trường hợp tiếp theo
                Temp = new Node();
                Temp.MaTran = new int[n, n];
                Array.Copy(tSo.MaTran, Temp.MaTran, tSo.MaTran.Length);
            }
            //Xét cột dọc bắt đầu từ cột cuối cùng -1 trở xuống
            if (c < n - 1 && c >= 0)
            {
                // thay đổi hướng đi của ma trận
                Temp.MaTran[h, c] = Temp.MaTran[h, c + 1];
                Temp.MaTran[h, c + 1] = 0;

                //cập nhật lại thông số của node
                Temp.SoManhSai = soMiengSaiViTri(Temp.MaTran);
                ChiSo++;
                Temp.ChiSo = ChiSo;
                Temp.Cha = tSo.ChiSo;
                Temp.g = g + Temp.SoManhSai;
                lstHuongDi.Add(Temp);

                //đến đây đã xết hết hướng đi nên không cần copy lại ma trận
            }
            #endregion

            return lstHuongDi;// phương thức trả về list lstHuongDi chưa all các trạng thái con có thể từ trạng thái cha
        }


        /// <summary>
        /// Chọn vị trí có chi phí tốt nhất trong Open
        /// </summary>
        /// <param name="Open">Tập Open</param>
        /// <returns>Vị trí tốt nhất</returns>

        //quản lý và xử lý tập Open & Close
        //thực hiện các thao tác để so sánh chi phí giữa các nút và quyết định xem nên cập nhật thông tin của nút hay không

        int viTriTotNhatOpen(List<Node> Open)
        //nhận danh sách Open và tìm vị trí của nút trong danh sách Open có chi phí (tổng chi phí g(n) và h(n)) tốt nhất
        {
            if (Open.Count != 0)
            {
                Node min = new Node();
                min = Open[0];
                int vt = 0;

                for (int i = 1; i < Open.Count; i++)
                    if (min.SoManhSai > Open[i].SoManhSai)// so sánh nút có số mảnh sai vị trí (SoManhSai) thấp hơn
                    {
                        min = Open[i];
                        vt = i;
                    }
                    else//Nếu có nhiều nút có cùng số mảnh sai vị trí, thì nó chọn nút có chi phí thấp hơn
                    {
                        if (min.SoManhSai == Open[i].SoManhSai)
                        {
                            if (min.g > Open[i].g)//g là chi phí
                            {
                                min = Open[i];
                                vt = i;
                            }
                        }
                    }
                return vt;
            }

            return 0;
        }


        /// <summary>
        /// So sánh chi phí của hai node
        /// </summary>
        /// <param name="ThamSo">Node cần so sánh</param>
        /// <param name="lst8So">Tập Open hoặc Close</param>
        /// <returns>trả về true nếu tốt hơn và cập nhật lại cha và chi phí cho node, ngược lại không làm gì và trả về false </returns>
        bool soSanhTotHon(Node tSo, List<Node> lst8So)//so sánh chi phí giữa nút
        {
            for (int i = 0; i < lst8So.Count; i++)
                if (haiMaTranBangNhau(tSo.MaTran, lst8So[i].MaTran))
                {
                    if (tSo.g < lst8So[i].g)
                    {
                        //vì 2 ma trận bằng nhau lên số mảnh sai vi trị là như nhau lên ta không cần cập nhật
                        lst8So[i].Cha = tSo.Cha;// cập nhật lại cha của hướng đi
                        lst8So[i].g = tSo.g;// cập nhật lại chi phí đường đi

                        return true;
                    }
                    else return false;
                }

            return false;
        }
        //các pthuc để quản lý trạng thái, so sánh và kiểm tra tính hợp lệ của các nút
        Node layNodeTrungTrongClose(Node tSo, List<Node> lst8So)// lấy nút trùng
        {
            Node Trung = new Node();
            for (int i = 0; i < lst8So.Count; i++)
                if (haiMaTranBangNhau(tSo.MaTran, lst8So[i].MaTran))
                {
                    Trung = lst8So[i];
                    break;
                }
            return Trung;
        }

        bool haiNodeTrungNhau(Node tSo, List<Node> lst8So)// kiểm tra xem 2 nút có trùng không nếu trùng ? nếu ko trùng?
        {
            for (int i = 0; i < lst8So.Count; i++)
                if (haiMaTranBangNhau(lst8So[i].MaTran, tSo.MaTran))
                    return true;

            return false;
        }



        bool haiMaTranBangNhau(int[,] a, int[,] b)//ktra 2 matrix a, b có = nhau ko( nó so sánh từng phần tử của 2 matrix)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                    if (a[i, j] != b[i, j])
                        return false;
            }

            return true;
        }




        // sinh một ma trận ngẫu nhiên để làm node bắt đầu
        public int[,] randomMaTran(int kickThuoc)
        {

            int[,] MaTran = new int[kickThuoc, kickThuoc];
            //khởi tạo ma trận 8 số
            MaTran[0, 0] = 1;
            MaTran[0, 1] = 2;
            MaTran[0, 2] = 3;
            MaTran[1, 0] = 4;
            MaTran[1, 1] = 5;
            MaTran[1, 2] = 6;
            MaTran[2, 0] = 7;
            MaTran[2, 1] = 8;
            MaTran[2, 2] = 0;//Why 0?How : đại điện cho mảnh trống và đại diện cho mảnh mà bạn có thể di chuyển đến



            //tập Close lưu lại các hướng đã đi để đảm bảo sinh ra hướng đi mới đảm bảo không trùng lặp
            List<int[,]> Close = new List<int[,]>();

            int n = MaTran.GetLength(0);//biến n lưu trữu kích thước của ma trận

            int[,] Temp = new int[n, n];
            Array.Copy(MaTran, Temp, MaTran.Length);
            Close.Add(Temp);//matrix trạng thái ban đầu được thêm vào list Close
            int h = 2, c = 2;

            Random rd = new Random();


            int t = rd.Next(1, 5);


            for (int r = 0; r < 20; r++)
            {
                if (h == 2 && c == 2)
                {
                    MaTran[h, c] = MaTran[h - 1, c];
                    MaTran[h - 1, c] = 0;
                    h--;
                    MaTran[h, c] = MaTran[h, c - 1];
                    MaTran[h, c - 1] = 0;
                    c--;

                }
                //Mỗi bước, một hướng di chuyển ngẫu nhiên (t) được chọn.
                //đi lên trên với t =1
                t = rd.Next(1, 5);
                if (h > 0 && h <= n - 1 && t == 1)
                {
                    MaTran[h, c] = MaTran[h - 1, c];
                    MaTran[h - 1, c] = 0;

                    if (!danhSachDaCoMaTran(MaTran, Close))
                    {
                        h--;
                        Temp = new int[n, n];
                        Array.Copy(MaTran, Temp, MaTran.Length);
                        Close.Add(Temp);
                    }
                    else
                    {
                        MaTran[h - 1, c] = MaTran[h, c];
                        MaTran[h, c] = 0;
                    }

                }

                t = rd.Next(1, 5);

                //đi sang trái với t=2
                if (c > 0 && c <= n - 1 && t == 2)
                {
                    MaTran[h, c] = MaTran[h, c - 1];
                    MaTran[h, c - 1] = 0;

                    if (!danhSachDaCoMaTran(MaTran, Close))
                    {
                        c--;
                        Temp = new int[n, n];
                        Array.Copy(MaTran, Temp, MaTran.Length);
                        Close.Add(Temp);
                    }
                    else
                    {
                        MaTran[h, c - 1] = MaTran[h, c];
                        MaTran[h, c] = 0;
                    }
                }

                t = rd.Next(1, 5);

                //đi xuống giưới với t=3
                if (h < n - 1 && h >= 0 && t == 3)
                {
                    MaTran[h, c] = MaTran[h + 1, c];
                    MaTran[h + 1, c] = 0;

                    if (!danhSachDaCoMaTran(MaTran, Close))
                    {
                        h++;
                        Temp = new int[n, n];
                        Array.Copy(MaTran, Temp, MaTran.Length);
                        Close.Add(Temp);
                    }
                    else
                    {
                        MaTran[h + 1, c] = MaTran[h, c];
                        MaTran[h, c] = 0;
                    }

                }

                t = rd.Next(1, 5);

                //đi sang phải với t = 4
                if (c < n - 1 && c >= 0 && t == 4)
                {
                    MaTran[h, c] = MaTran[h, c + 1];
                    MaTran[h, c + 1] = 0;

                    if (!danhSachDaCoMaTran(MaTran, Close))
                    {
                        c++;
                        Temp = new int[n, n];
                        Array.Copy(MaTran, Temp, MaTran.Length);
                        Close.Add(Temp);
                    }
                    else
                    {
                        MaTran[h, c + 1] = MaTran[h, c];
                        MaTran[h, c] = 0;
                    }
                }

            }

            // trả về hướng đi cuối dùng trong danh sách hướng đi
            return Close[Close.Count - 1];
        }

        //So sánh nếu ma trận a đã có trang danh sách Close  thì trả về true ngược lại trả về false
        bool danhSachDaCoMaTran(int[,] a, List<int[,]> Close)
        // kiểm tra xem ma trận a đã có trong danh sách Close chưa. nếu chưa thì sao, rồi thì sao?
        {
            for (int i = 0; i < Close.Count; i++)
            {
                if (haiMaTranBangNhau(a, Close[i]))
                {
                    return true;
                }
            }

            return false;
        }
        // helper

        public string BoardToString(int[,] board)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++) sb.Append(board[i, j] + " ");
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }


}