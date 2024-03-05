using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodStore.DTO
{
    public class DTOLoai
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set;}
        public DTOLoai(){}

        public DTOLoai(string MaLoai, string TenLoai)
        {
            this.MaLoai = MaLoai;
            this.TenLoai = TenLoai;
        }
    }
}
