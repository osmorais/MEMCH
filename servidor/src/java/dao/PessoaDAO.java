/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import dao.InterfaceDAO.IPessoaDAO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import modelo.Pessoa;
import modelo.Registro;
import util.ConnectionFactory;

/**
 *
 * @author osmar
 */
public class PessoaDAO implements IPessoaDAO{
//                                Table "public.pessoa"
// Column |         Type          |                      Modifiers                      
//--------+-----------------------+-----------------------------------------------------
// id     | integer               | not null default nextval('pessoa_id_seq'::regclass)
// nome   | character varying(20) | 
// cpf    | character varying(14) | 
//Indexes:
//    "pk_pessoa" PRIMARY KEY, btree (id)
//Referenced by:
//    TABLE "usuario" CONSTRAINT "pessoafk" FOREIGN KEY (pessoaid) REFERENCES pessoa(id)
    private final String SELECTALL = "SELECT * FROM PESSOA;";
    private final String SELECTID = "SELECT * FROM PESSOA WHERE ID=?;";
    private static final String INSERT = "INSERT INTO PESSOA "
            + "(NOME, CPF) VALUES "
            + "(?,?)";
    private static final String DELETE = "DELETE FROM PESSOA WHERE ID=?";
    private static final String UPDATE = "UPDATE PESSOA "
            + "SET NOME=?, CPF=?"
            + " WHERE ID=?";
    
    private Connection conexao;
    @Override
    public void cadastrar(Pessoa pessoa) {
try {
            ConnectionFactory con = new ConnectionFactory();

            this.conexao = con.getConnection();
            PreparedStatement stmt = this.conexao.prepareStatement(INSERT,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setString(1, pessoa.getNome());
            stmt.setString(2, pessoa.getCpf());
            
            stmt.execute();
            
            ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                pessoa.setId(rs.getInt(1));
            }
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public void consultar(Pessoa pessoa) {
        try {
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECTID);
            stmt.setInt(1, pessoa.getId());

            ResultSet rs = stmt.executeQuery();
            if (rs.next()) {
                pessoa.setId(rs.getInt("id"));
                pessoa.setNome(rs.getString("nome"));
                pessoa.setCpf(rs.getString("cpf"));
            }
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public void alterar(Pessoa pessoa) {
        try {
            ConnectionFactory con = new ConnectionFactory();
            this.conexao = con.getConnection();

            PreparedStatement stmt = this.conexao.prepareStatement(UPDATE,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setString(1, pessoa.getNome());
            stmt.setString(2, pessoa.getCpf());
            
            int lastId = 0;

            stmt.execute();
            final ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                lastId = rs.getInt(1);
            }

            pessoa.setId(lastId);
            ConnectionFactory.closeConnection(this.conexao, stmt);
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public void remover(Pessoa pessoa) {
        try {
            ConnectionFactory con = new ConnectionFactory();

            this.conexao = con.getConnection();
            PreparedStatement stmt = this.conexao.prepareStatement(DELETE);
            stmt.setInt(1, pessoa.getId());

            stmt.execute();
            
            pessoa.setId(0);
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public ArrayList<Pessoa> listar() {
        try {
            ArrayList<Pessoa> arrPessoa = new ArrayList<Pessoa>();
            
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECTALL);
            
            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                Pessoa pessoa = new Pessoa();
                pessoa.setId(rs.getInt("id"));
                pessoa.setNome(rs.getString("nome"));
                pessoa.setCpf(rs.getString("cpf"));
                arrPessoa.add(pessoa);
            }
            return arrPessoa;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }
    
}
