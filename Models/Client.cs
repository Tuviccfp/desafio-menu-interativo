using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuInterativo.Models {
internal class Client {
    public string Name { get; set; }
    public string FuncStaff { get; set; }
    public int Matricula { get; set; }    
    
    public Client(string name, string funcStaff, int matricula)
    {
        Name = name;
        FuncStaff = funcStaff;
        Matricula = matricula;
    }
        public void Search(int value) {
            if (value == Matricula)
            {
                Console.WriteLine($"Funcionário: {Name} \n Função: {FuncStaff} \n Matricula: {Matricula}");  
            }
        }
        public override string ToString()
        {
            return $"Funcionário: {Name} \n Função: {FuncStaff} \n Matricula: {Matricula} \n";
        }
    }
}