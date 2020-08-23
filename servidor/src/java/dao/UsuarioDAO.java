/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import dao.InterfaceDAO.IPessoaDAO;
import dao.InterfaceDAO.IUsuarioDAO;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import modelo.Pessoa;
import modelo.Usuario;
import util.ConnectionFactory;

/**
 *
 * @author osmar
 */
public class UsuarioDAO implements IUsuarioDAO{
//                                     Table "public.usuario"
//  Column  |         Type          |                      Modifiers                       
//----------+-----------------------+------------------------------------------------------
// id       | integer               | not null default nextval('usuario_id_seq'::regclass)
// login    | character varying(20) | 
// senha    | character varying(20) | 
// pessoafk | integer               | not null
//Indexes:
//    "pk_usuario" PRIMARY KEY, btree (id)
//Foreign-key constraints:
//    "pessoafk" FOREIGN KEY (pessoaid) REFERENCES pessoa(id)
    private final String SELECTALL = "SELECT * FROM USUARIO;";
    private final String SELECTID = "SELECT * FROM USUARIO WHERE ID=?;";
    private static final String INSERT = "INSERT INTO USUARIO "
            + "(LOGIN, SENHA, PESSOAID) VALUES "
            + "(?,?,?)";
    private static final String DELETE = "DELETE FROM USUARIO WHERE ID=?";
    private static final String UPDATE = "UPDATE USUARIO "
            + "SET LOGIN=?, SENHA=?, PESSOAFK=?"
            + " WHERE ID=?";
    
    private Connection conexao;
    
    @Override
    public void cadastrar(Usuario usuario) {
         try {
            ConnectionFactory con = new ConnectionFactory();

            this.conexao = con.getConnection();
            PreparedStatement stmt = this.conexao.prepareStatement(INSERT,
                    Statement.RETURN_GENERATED_KEYS);
            stmt.setString(1, usuario.getLogin());
            stmt.setString(2, usuario.getSenha());
            
            IPessoaDAO pessoadao = new PessoaDAO();
            Pessoa pessoa = usuario.getPessoa();
            
            pessoadao.cadastrar(pessoa);
            stmt.setInt(3, pessoa.getId());
            
            stmt.execute();
            
            ResultSet rs = stmt.getGeneratedKeys();
            if (rs.next()) {
                usuario.setId(rs.getInt(1));
            }
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public void consultar(Usuario alerta) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void alterar(Usuario alerta) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void remover(Usuario usuario) {
    try {
            ConnectionFactory con = new ConnectionFactory();

            this.conexao = con.getConnection();
            PreparedStatement stmt = this.conexao.prepareStatement(DELETE);
            stmt.setInt(1, usuario.getId());

            stmt.execute();
            
            usuario.setId(0);
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }

    @Override
    public ArrayList<Usuario> listar() {
        try {
            ArrayList<Usuario> arrUsuario = new ArrayList<Usuario>();
            
            ConnectionFactory con = new ConnectionFactory();

            conexao = con.getConnection();
            PreparedStatement stmt = conexao.prepareStatement(SELECTALL);
            
            ResultSet rs = stmt.executeQuery();
            while (rs.next()) {
                Usuario usuario = new Usuario();
                usuario.setId(rs.getInt("id"));
                usuario.setLogin(rs.getString("login"));
                usuario.setSenha(rs.getString("senha"));
                
                IPessoaDAO pessoadao = new PessoaDAO();
                Pessoa pessoa = new Pessoa();
                pessoa.setId(rs.getInt("pessoafk"));
                
                pessoadao.consultar(pessoa);
                
                usuario.setPessoa(pessoa);
                
                arrUsuario.add(usuario);
            }
            return arrUsuario;
        } catch (SQLException ex) {
            throw new RuntimeException("Erro: ", ex);
        }
    }
    
}
