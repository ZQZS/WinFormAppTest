using System;
using System.Collections;
using WinFormsApp1.Common;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    //�����ࣺpartial
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        bool bbb;
        int iii;
        int? iii2;
        string snull;
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //��������
            byte b = byte.MaxValue;
            byte bs = byte.MinValue;

            short s = short.MaxValue;
            short ss = short.MinValue;

            int t = int.MaxValue;
            int ts = int.MinValue;

            long l = long.MaxValue;
            long ls = long.MinValue;

            short y = 0;
            int i = 0;
            i = y;
            //y = i;

            //����������
            float f = float.MaxValue;
            float fs = float.MinValue;
            float fl = 1.1f;
            fl = s;
            fl = i;
            fl = l;
            //l = fl;

            double d = double.MaxValue;
            double ds = double.MinValue;
            double dl = 1.1;
            dl = fl; dl = ls; dl = y;

            decimal dM = decimal.MaxValue;
            decimal dsM = decimal.MinValue;
            decimal dlM = 1.1m;

            bool bt = true;
            bool bf = false;
            bool bl = 1 == 1;
            //MessageBox.Show(bl.ToString());
            bool bl2 = 1 > 1;
            //MessageBox.Show(bl2.ToString());

            //ֵ����,û�и�ֵʱϵͳ���Զ���ֵ0��false,��?���ÿ�
            //MessageBox.Show(iii2.ToString());

            //�ַ�������
            int age = 123;
            string str = "my name is OVO,boy" + age;
            string name = "Taro";
            string str2 = $"my name is {name},boy,{age}";

            //MessageBox.Show(str2);
            char c = 'i';
            //MessageBox.Show(c.ToString());

            int ii = 1;
            int yy = ii + 1;
            //MessageBox.Show(yy.ToString());

            //MessageBox.Show(snull);
            //int ix = 0;
            int? ix = 0;
            ix = null;

            int ixx = iii2 ?? 1;
            //MessageBox.Show((++ixx).ToString());

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            //switch ����� if ��֧����ŵ�������һ����λ������Ҫ����
            string res = name switch
            {
                "123" => "456",
                "888" => "898",
                _ => "000"
            };
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            MessageBox.Show(res.ToString());
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string str = "5.1";
            double dou = 5.21;
            double i1 = double.Parse(str);
            MessageBox.Show(Convert.ToInt32(5.5).ToString());
            MessageBox.Show(Convert.ToInt32(3.25).ToString());
            MessageBox.Show(Convert.ToInt32(5.4).ToString());
            MessageBox.Show(Convert.ToInt32(3.54).ToString());
            MessageBox.Show(Convert.ToInt32(5.55).ToString());

        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            string[] name = { "s", "b", "c", "d", "e" };
            string[] names = new string[8];
            int[] names2 = new int[2] { 0, 0 };

            foreach (var item in name)
            {
                if (item == "d") MessageBox.Show("d�ؼ�", "hello");
                else MessageBox.Show("���ؼ�");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //��ֵ out ���ô���,���뺯���ڶ�out ���εĲ������и�ֵ
            //int res;
            Add(1, 3, out int res);
            MessageBox.Show(res.ToString());
        }
        /// <summary>
        /// �ӷֺ���
        /// </summary>
        /// <param name="firstNum">��һ������</param>
        /// <param name="lastNum">�ڶ�������</param>
        /// <returns>�ӷ����</returns>
        void Add(int firstNum, int lastNum, out int res)
        {
            res = firstNum + lastNum;
        }
        void Add2(int firstNum, int lastNum, ref int res)
        {
            res = firstNum + lastNum;
        }
        private void btnRef_Click(object sender, EventArgs e)
        {
            //��ֵ ref ���ô���,�����ڿ�ѡ��ref ���εĲ������и�ֵ��ref���εı��븳��ֵ
            int res = 0;
            Add2(1, 6, ref res);
            MessageBox.Show(res.ToString());

        }
        //param ����ֻ����Ϊ���һ������ ��int Add3(int a ,params int[] ints)
        int AddAll(params int[] ints)
        {
            int res = 0;
            if (ints.Length == 0) return 0;
            else
            {
                foreach (var item in ints)
                {
                    res += item;
                }
            }
            return res;
        }

        private void btnParam_Click(object sender, EventArgs e)
        {

            MessageBox.Show(AddAll(1, 6, 3, 6, 8, 3, 2, 1).ToString());
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void btnClassTest_Click(object sender, EventArgs e)
        {
            //Person zhangsan = new Person();
            //zhangsan.Name = "zg";
            //zhangsan.Age = 20;
            //zhangsan.Sex = "boy";
            Person zhangsan = new()
            {
                Name = "Test",
                Age = 1,
                Sex = "boy",
                Id = 1
            };
            string res = zhangsan.Eat();
            //MessageBox.Show(Helper.addJuhao(res));
            MessageBox.Show(res.addJuhao());

        }

        private void btnInherit_Click(object sender, EventArgs e)
        {
            //Car car = new()
            //{
            //    Color = "red",
            //    Length = 10,
            //};
            //car.Run();
            Truck truck = new()
            {
                Color = "blue",
                Length = 20,
                Carriage = "rich"
            };
            CarRun(truck);
            //truck.Run();
            //MessageBox.Show(truck.Freight());

            //�����滻ԭ�� ʹ�ó�������ʹ���ڷ��� ���ܸ�����������ڽ����������࣬���ù�ͬ�ķ��������ٴ����ظ���
            //Car car = new Truck();
            //car.Length = 1;
            //car.Run();
            SUV Suv = new()
            {
                Seat = "124",
                Color = "yellow",
                Length = 5,
            };
            CarRun(Suv);
        }
        public void CarRun(Car car)
        {
            //���෴ת����
            //Truck truck = (Truck)car;//ʹ��try-catch�����Ĵ�
            //Truck truck2 = car as Truck;//���Ƽ�
            //��ת��ת����ʹ������"����"�����Ͳ���ת���ᱨ��ʹ��as�����Ͳ����򷵻�null�����ᱨ��
            car.Run();
        }

        private void btnInterfaces_Click(object sender, EventArgs e)
        {
            IUser user = new User()
            {
                Name = "Test",
            };
            user.SayHello();
        }

        private void btnInterface2_Click(object sender, EventArgs e)
        {
            IUsb light = new ULight("̨��");
            light.EquipmentWorking();
            IUsb upan = new UPan("U��");
            upan.EquipmentWorking();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string str = "�ҵ�" +
                " ���ֽ�qiu";
            //ԭʼ�ַ���
            string OStr = $"""
                        �ҵ���
                            �ֽ�
                          qiu {str}
                        """;
            string OJson =
                        """
                        {
                            name:"���ҵ"��
                            age:"10"
                        }
                        """;
            string OJson1 =
            $$"""
                        {
                            name:"{{str}}"��
                            age:"10"
                        }
                        """;
            label1.Text = OJson1;
        }

        private void btnValueType_Click(object sender, EventArgs e)
        {
            //int i = 1;
            //int j = 1;
            //j = 3;
            //label1.Text = $"i:{i},j:{j}";

            User user1 = new User() { Name = "1123" };
            User user2 = user1;

        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            ArrayList arrayList2 = new ArrayList();
            arrayList2.Add("ab");
            arrayList2.Add("ac");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("A");
            arrayList.Insert(1, "B");
            arrayList.Add("8");
            arrayList.Add("4");
            arrayList.Add("4");
            arrayList.RemoveAt(0);
            arrayList.Remove("4");
            arrayList.AddRange(arrayList2);

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person() { Age = 1, Name = "aaa3", Sex = "boy" });
            list.Add(new Person() { Age = 1, Name = "aaa2", Sex = "boy" });
            list.Add(new Person() { Age = 1, Name = "aaa", Sex = "boy" });
            list.Add(new Person() { Age = 1, Name = "aaa4", Sex = "boy" });
            Person? res = null;

            //res = list.FirstOrDefault(m => m.Name == "aaa");
            List<Person>? list2 = null;
            list2 = list.FindAll(x => x.Age == 1);
            //foreach (Person person in list)
            //{
            //    if (person.Name == "aaa")
            //    {
            //        res = person;
            //        break;
            //    }
            //}
            if (res != null)
            {
                var hash = res.GetHashCode();
                list.Remove(res);
                MessageBox.Show(hash.ToString());
            }

        }

        private void btnListShow_Click(object sender, EventArgs e)
        {
            FormList formList = new FormList();
            formList.ShowDialog();//�����岻�ܲ���
            //formList.Show();//��������Բ���
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("123", "13");
            dic.Add("456", "123");
            dic["789"] = "12354";
            Dictionary<int, string> dic2 = new Dictionary<int, string>()
            {
                {1,"123" }, {2 ,"123"} , {3, "123"} , {4,"456" }
            };
            var _temp = dic2[2];
            foreach (var item in dic2)
            {
                var key = item.Key;
                var value = item.Value;
                //KeyValuePair<int, string> keyValue = new KeyValuePair<int, string>(key,)
            }
        }

        private void btnExpendFunc_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = "yuan";
            person.Born();//Helper2 ��չ����
            person.AddId(123456);
            person.ShowPerson();
            person.JoinPerson();
        }

        public class MyKeyValuePair<TKey, TValue>
        {
            private TKey _key;
            private TValue _value;
            public MyKeyValuePair(TKey key, TValue value)
            {
                _key = key;
                _value = value;
            }
            public TKey Key => _key;
            public TValue Value => _value;
        }
    }
}