using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_03
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instância a classe (cria um objeto da classe
            Animal o_Cachorro = new Animal();

            //informa os valores dos atributos
            o_Cachorro.nome = "Xei de Puga";
            o_Cachorro.idade = 10;

            //Obtem os valores dos atributos
            Console.WriteLine("\n***** Cachorro *****");
            Console.WriteLine("Nome: " + o_Cachorro.nome);
            Console.WriteLine("Idade: " + o_Cachorro.idade);

            //Instância a classe (cria um objeto da classe
            Animal o_Gato = new Animal();

            //informa os valores dos atributos
            o_Gato.nome = "Tigresa";
            o_Gato.idade = 5;

            //Obtem os valores dos atributos
            Console.WriteLine("\n***** Gato *****");
            Console.WriteLine("Nome: " + o_Gato.nome);
            Console.WriteLine("Idade: " + o_Gato.idade);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mother o_Juliana = new Mother();

            o_Juliana.nome = "Juliana";
            o_Juliana.endereco = "Rua X, 10";
            o_Juliana.datNasc = 1972;
            o_Juliana.fone = "99999-1234";

            Console.WriteLine("\n***** Mãe *****");
            Console.WriteLine("Nome: " + o_Juliana.nome);
            Console.WriteLine("Endereço: " + o_Juliana.endereco);
            Console.WriteLine("Ano de nascimento: " + o_Juliana.datNasc);
            Console.WriteLine("Telefone: " + o_Juliana.fone);

            Baby o_Mariana = new Baby();

            o_Mariana.nome = "Mariana";
            o_Mariana.datNasc = 2000;
            o_Mariana.peso = 9.200f;            
            o_Mariana.altura = 0.72f;
            o_Mariana.nomeMae = "Mariana";
            o_Mariana.nomeMedico = "Mauro";

            Console.WriteLine("\n***** Baby *****");
            Console.WriteLine("Nome: " + o_Mariana.nome);
            Console.WriteLine("Ano de nascimento: " + o_Mariana.datNasc);
            Console.WriteLine("Peso: " + o_Mariana.peso);
            Console.WriteLine("Altura: " + o_Mariana.altura);
            Console.WriteLine("Nome da mãe: " + o_Mariana.nomeMae);
            Console.WriteLine("Nome do médico: " + o_Mariana.nomeMedico);



            Doctor o_Mauro = new Doctor();

            o_Mauro.nome = "Mauro";
            o_Mauro.crm = "48612";
            o_Mauro.especialidade = "Pediatria";
            o_Mauro.celular = "99999-4321";

            Console.WriteLine("\n***** Médico *****");
            Console.WriteLine("Nome: " + o_Mauro.nome);
            Console.WriteLine("Endereço: " + o_Mauro.crm);
            Console.WriteLine("Ano de nascimento: " + o_Mauro.especialidade);
            Console.WriteLine("Telefone: " + o_Mauro.celular);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                User o_Usuario = new User();

                o_Usuario.Nome = "Maria";
                o_Usuario.AnoNasc = 1987;
                o_Usuario.Senha = "1478527";

                Console.WriteLine("\n***** Dados Usuário *****");
                Console.WriteLine("Nome: " + o_Usuario.Nome);
                Console.WriteLine("Ano de nascimento: " + o_Usuario.AnoNasc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Tratamento de Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Criptografia o_Senha = new Criptografia();

            o_Senha.Dado = 100;

            Console.WriteLine("Dado: " + o_Senha.Dado);
            Console.WriteLine("Dado Criptografado: " + o_Senha.dado);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno o_Aluno = new Aluno();

                o_Aluno.CodAluno = 123;
                o_Aluno.Nome = "Maria";
                o_Aluno.NotaP1 = 8.75f;
                o_Aluno.NotaP2 = 9.12f;

                Console.WriteLine("\n***** Dados do Aluno *****");
                Console.WriteLine("Código do aluno: " + o_Aluno.CodAluno);
                Console.WriteLine("Nome: " + o_Aluno.Nome);
                Console.WriteLine("Nota P1: " + o_Aluno.NotaP1);
                Console.WriteLine("Nota P2: " + o_Aluno.NotaP2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Tratamento de Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
