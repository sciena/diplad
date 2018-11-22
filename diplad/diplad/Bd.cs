using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace diplad
{
    class Bd
    {
        private static SQLiteConnection conn = null; //VARIAVEL PARA A CONEXAO
        private static string connectionString = "Data Source=diplad.db;"; //VARIAVEL COM OS DADOS DE QUAL O BANCO ESTA SENDO CONECTADO


        public static void retirada(DateTime datahoraret, int cod_material, int siaperet, string setor) //FUNCAO PARA REGISTRAR A RETIRADA NO BANCO DE DADOS, RECEBE AS INFORMACOES QUE ESTAO ENTRE PARENTESES COMO PARAMETROS
        {
            conn = new SQLiteConnection(connectionString); //ATIVA A VARIAVEL DE CONEXAO
            conn.Open(); //ABRE A CONEXAO
            string sql = "INSERT INTO retirada (datahoraret,cod_material,siaperet,setor) VALUES (@datahoraret,@cod_material,@siaperet,@setor)"; //CRIA O COMANDO PRO BD
            SQLiteCommand cmd = new SQLiteCommand(sql, conn); //ASSOCIA O COMANDO COM A CONEXAO
            cmd.Parameters.AddWithValue("@datahoraret", datahoraret); //ADICIONA O VALOR QUE VEIO COMO PARAMETRO COM O TEXTO DO COMANDO
            cmd.Parameters.AddWithValue("@cod_material", cod_material); //ADICIONA O VALOR QUE VEIO COMO PARAMETRO COM O TEXTO DO COMANDO
            cmd.Parameters.AddWithValue("@siaperet", siaperet); //ADICIONA O VALOR QUE VEIO COMO PARAMETRO COM O TEXTO DO COMANDO
            cmd.Parameters.AddWithValue("@setor", setor); //ADICIONA O VALOR QUE VEIO COMO PARAMETRO COM O TEXTO DO COMANDO
            int res = cmd.ExecuteNonQuery(); //EXECUTA O COMANDO
            conn.Close(); //FECHA A CONEXAO
            conn.Dispose(); //LIBERA A MEMORIA
        }
        public static int validsiape(int siape, string nome, string senha) //FUNCAO PARA VER SE OS DADOS DO SERVIDOR (SIAPE/NOME E SENHA) ESTAO CORRETOS. RETORNA UM NUMERO
        {
            conn = new SQLiteConnection(connectionString); //ATIVA A VARIAVEL DE CONEXAO
            conn.Open(); //ABRE A CONEXAO
            string sql = ""; //CRIA A VARIAVEL DO COMANDO SQL, VAZIA POR ENQUANTO
            if (siape == 0)  //VE SE O SIAPE FOI DIGITADO
            {
                sql = "SELECT siape FROM servidor WHERE nome = '" + nome + "' and senha = @senha;"; //SE O SIAPE NAO FOI DIGITADO MONTA O TEXTO DO COMANDO COM O NOME DO SER
            }
            else
            {
                sql = "SELECT siape FROM servidor WHERE siape = '" + siape + "' and senha = @senha;"; //SE O SIAPE FOI SIM DIGITADO MONTA O TEXTO DO COMANDO SQL COM O SIAPE DO SER
            }

            SQLiteCommand cmd = new SQLiteCommand(sql, conn); //ASSOCIA O COMANDO COM A CONEXAO
            cmd.Parameters.AddWithValue("@senha", senha); //ADICIONA O VALOR QUE VEIO COMO PARAMETRO COM O TEXTO DO COMANDO (SÓ A SENHA, JÁ QUE NOME/SIAPE FOI COLOCADO NO PERSONALIZADO)
            int siaperet = 0; //CRIA A VARIAVEL DE RESULTADO ZERADA, ASSIM SE NAO TIVER RESULTADO NENHUM ELA CONTINUA ZERADA E NAO DA ERRO
            SQLiteDataReader rs = cmd.ExecuteReader(); //EXECUTA O COMANDO SQL E TRAZ UM VETOR COM O RESULTADO (RS)
            if (rs.Read()) //TESTA SE O VETOR CONTEM ALGUMA LINHA. SE POR ACASO O NOME/SIAPE OU SENHA FOREM DIGITADOS ERRADOS O RESULTADO É ZERO LINHAS
            {
                siaperet = rs.GetInt32(0); //PEGA O VALOR DO CAMPO 0 DO VETOR, QUE É O SIAPE, E COLOCA NA VARIAVEL SIAPERET
            }
            rs.Close(); //FECHA A VARIAVEL DE VETOR DE RESULTADO DO BANCO
            conn.Close();//FECHA A CONEXAO
            conn.Dispose();//LIBERA MEMORIA
            return siaperet;//RETORNA A VARIAVEL COM O SIAPE DA PESSOA OU NUMERO ZERO SE OS DADOS FOREM INVALIDOS
        }

        public static int idmaterial(string nome, int codigo)
        {
            conn = new SQLiteConnection(connectionString); //ATIVA A VARIAVEL DE CONEXAO
            conn.Open(); //ABRE A CONEXAO
            string sql = ""; //CRIA A VARIAVEL DO COMANDO SQL, VAZIA POR ENQUANTO
            if (codigo == 0)  //VE SE O codigo FOI DIGITADO
            {
                sql = "SELECT codigo FROM materiais WHERE nome = '" + nome + "';"; //SE O codigo NAO FOI DIGITADO MONTA O TEXTO DO COMANDO COM O nome
            }
            else
            {
                sql = "SELECT codigo FROM materiais WHERE codigo = '" + codigo + "';"; //SE O codigo FOI SIM DIGITADO MONTA O TEXTO DO COMANDO SQL COM O codigo
            }

            SQLiteCommand cmd = new SQLiteCommand(sql, conn); //ASSOCIA O COMANDO COM A CONEXAO
            int codret = 0; //CRIA A VARIAVEL DE RESULTADO ZERADA, ASSIM SE NAO TIVER RESULTADO NENHUM ELA CONTINUA ZERADA E NAO DA ERRO
            SQLiteDataReader rs = cmd.ExecuteReader(); //EXECUTA O COMANDO SQL E TRAZ UM VETOR COM O RESULTADO (RS)
            if (rs.Read()) //TESTA SE O VETOR CONTEM ALGUMA LINHA. SE POR ACASO O NOME/codigo FOREM DIGITADOS ERRADOS O RESULTADO É ZERO LINHAS
            {
                codret = rs.GetInt32(0); //PEGA O VALOR DO CAMPO 0 DO VETOR, QUE É O codigo, E COLOCA NA VARIAVEL 
            }
            rs.Close(); //FECHA A VARIAVEL DE VETOR DE RESULTADO DO BANCO
            conn.Close();//FECHA A CONEXAO
            conn.Dispose();//LIBERA MEMORIA
            return codret;//RETORNA A VARIAVEL COM O codigo DO material OU NUMERO ZERO SE OS DADOS FOREM INVALIDOS
        }
        
            public static void cadastrarservidor(int siape, string nome, string senha)
        {
            conn = new SQLiteConnection(connectionString); //ATIVA A VARIAVEL DE CONEXAO
            conn.Open(); //ABRE A CONEXAO
            string sql = "INSERT INTO servidor (siape,nome,senha) VALUES (@siape,@nome,@senha)"; //CRIA O COMANDO PRO BD
            SQLiteCommand cmd = new SQLiteCommand(sql, conn); //ASSOCIA O COMANDO COM A CONEXAO
            cmd.Parameters.AddWithValue("@siape", siape); //ADICIONA O VALOR QUE VEIO COMO PARAMETRO COM O TEXTO DO COMANDO
            cmd.Parameters.AddWithValue("@nome", nome); //ADICIONA O VALOR QUE VEIO COMO PARAMETRO COM O TEXTO DO COMANDO
            cmd.Parameters.AddWithValue("@senha", senha); //ADICIONA O VALOR QUE VEIO COMO PARAMETRO COM O TEXTO DO COMANDO
            int res = cmd.ExecuteNonQuery(); //EXECUTA O COMANDO
            conn.Close(); //FECHA A CONEXAO
            conn.Dispose(); //LIBERA A MEMORIA



        }
        public static void devolver(DateTime datahoradev, int cod_material, int siapedev)
        {
            conn = new SQLiteConnection(connectionString); //ATIVA A VARIAVEL DE CONEXAO
            conn.Open(); //ABRE A CONEXAO
            string sql = " Update retirada set datahoradev=@datahoradev,siapedev=@siapedev where  Codigo = (select codigo from retirada where cod_material = @cod_material order by datahoraret desc limit 1)"; //CRIA O COMANDO PRO BD
            SQLiteCommand cmd = new SQLiteCommand(sql, conn); //ASSOCIA O COMANDO COM A CONEXAO
            cmd.Parameters.AddWithValue("@datahoradev", datahoradev); //ADICIONA O VALOR QUE VEIO COMO PARAMETRO COM O TEXTO DO COMANDO
            cmd.Parameters.AddWithValue("@cod_material", cod_material); //ADICIONA O VALOR QUE VEIO COMO PARAMETRO COM O TEXTO DO COMANDO
            cmd.Parameters.AddWithValue("@siapedev", siapedev); //ADICIONA O VALOR QUE VEIO COMO PARAMETRO COM O TEXTO DO COMANDO
            int res = cmd.ExecuteNonQuery(); //EXECUTA O COMANDO
            conn.Close(); //FECHA A CONEXAO
            conn.Dispose(); //LIBERA A MEMORIA
        }
        public static void cadastrarmateriais(int codigo, string nome)
        {
            conn = new SQLiteConnection(connectionString); //ATIVA A VARIAVEL DE CONEXAO
            conn.Open(); //ABRE A CONEXAO
            string sql = "INSERT INTO materiais (codigo,nome) VALUES (@codigo,@nome)"; //CRIA O COMANDO PRO BD
            SQLiteCommand cmd = new SQLiteCommand(sql, conn); //ASSOCIA O COMANDO COM A CONEXAO
            cmd.Parameters.AddWithValue("@codigo", codigo); //ADICIONA O VALOR QUE VEIO COMO PARAMETRO COM O TEXTO DO COMANDO
            cmd.Parameters.AddWithValue("@nome", nome); //ADICIONA O VALOR QUE VEIO COMO PARAMETRO COM O TEXTO DO COMANDO
            int res = cmd.ExecuteNonQuery(); //EXECUTA O COMANDO
            conn.Close(); //FECHA A CONEXAO
            conn.Dispose(); //LIBERA A MEMORIA
        }

        public static DataTable relatorio()
        {
            conn = new SQLiteConnection(connectionString); //ATIVA A VARIAVEL DE CONEXAO
            conn.Open(); //ABRE A CONEXAO
            string sql = "select " +
                "datetime(r.datahoraret) as 'Retirada '," + 
                "r.cod_material as 'material ' ," + 
                "m.nome as 'nome_material' ," + 
				"r.setor as 'setor', " + 
                "sr.nome as 'retirado por' , " +
                "datetime(r.datahoradev) as 'entrega'  ," +
                "sd.nome as 'devolvido por ' " +
                "from " +
                "retirada r " + 
                "left join materiais m on r.cod_material = m.codigo " +

                "left join servidor sr on r.siaperet = sr.siape " + 

                 "left join servidor sd on r.siapedev = sd.siape " + 
                "order by " +
                "datetime(r.datahoraret) ";//CRIA O COMANDO PRO BD
            SQLiteCommand cmd = new SQLiteCommand(sql, conn); //ASSOCIA O COMANDO COM A CONEXAO          
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable visualizar()
        {
            conn = new SQLiteConnection(connectionString); //ATIVA A VARIAVEL DE CONEXAO
            conn.Open(); //ABRE A CONEXAO
            string sql = "select " +
                "r.codigo as Cod, "+
                "datetime(r.datahoraret) as 'Retirada '," +
                "r.cod_material as 'material ' ," +
                "m.nome as 'nome_material' ," +
                "r.setor as 'setor', " +
                "sr.nome as 'retirado por', " +
                "'DEVOLVER' as Devolver "+
                "from " +
                "retirada r " +
                "left join materiais m on r.cod_material = m.codigo " +

                "left join servidor sr on r.siaperet = sr.siape " +
                "where r.siapedev is null "+
                "order by " +
                "datetime(r.datahoraret) ";//CRIA O COMANDO PRO BD
            SQLiteCommand cmd = new SQLiteCommand(sql, conn); //ASSOCIA O COMANDO COM A CONEXAO          
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
