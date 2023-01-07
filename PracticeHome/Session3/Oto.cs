using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.PracticeHome.Session3
{
    internal class Oto
    {
        /*
        private String brand;
        private string type;

        public string Brand { get => brand; set => brand=value;  }
        public string Type { get => type; set => type = value; }
        */

        // khi chỉ sử dụng dư liệu chỉ để transfer object thông thường nên sử dụng thuộc tính trừu tượng (abtract property)
        // hoặc không cần sử dụng ô nhớ; vì khi nào gán giá trị nào thì thuộc tính đó mới tạo ô nhớ
        public string Brand { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }

        private List<string> machines = new List<string>();
        private List<string> machines2 = new List<string>();

        public string this[int index] // indexer có thể chứa nhiều index like [int index,int id2]
        {
            //Oto o = new();  Console.WriteLine(o[0]);    => Camera
            get => machines[index];
            set => machines[index] = value;
        }

        public Oto() {
            machines.Add("Camera");
            machines.Add("Loa");
        }
    }
}
