/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import dao.AlertaDAO;
import dao.HidrometroDAO;
import dao.InterfaceDAO.IAlertaDAO;
import dao.InterfaceDAO.IHidrometroDAO;
import dao.InterfaceDAO.IRegistroDAO;
import dao.InterfaceDAO.IRegraDAO;
import dao.RegistroDAO;
import dao.RegraDAO;
import java.util.ArrayList;
import modelo.Hidrometro;



/**
 *
 * @author osmar
 */
public class SrvcHidrometro {
    public static Hidrometro cadastrar(Hidrometro hidrometro){

        IHidrometroDAO hidrometrodao = new HidrometroDAO();
        hidrometrodao.cadastrar(hidrometro);
        
        hidrometro.getRegras().stream().map((regra) -> {
            IRegraDAO regradao = new RegraDAO();
            regradao.cadastrar(regra, hidrometro);
            return regra;
        }).forEachOrdered((regra) -> {
            hidrometro.getRegras().add(regra);
        });
        
        return hidrometro;
    }
    
    public static Hidrometro consultar(Hidrometro hidrometro){

        IHidrometroDAO hidrometrodao = new HidrometroDAO();
        hidrometrodao.consultar(hidrometro);
        
        return hidrometro;
    }
    
    public static Hidrometro alterar(Hidrometro hidrometro){

        IHidrometroDAO hidrometrodao = new HidrometroDAO();
        hidrometrodao.alterar(hidrometro);
        
        hidrometro.getRegras().stream().map((regra) -> {
            IRegraDAO regradao = new RegraDAO();
            regradao.alterar(regra, hidrometro);
            return regra;
        }).forEachOrdered((regra) -> {
            hidrometro.getRegras().add(regra);
        });
        
        return hidrometro;
    }
    
    public static ArrayList<Hidrometro> listar(){
        
        //ArrayList<Registro> arrdepartamento = new ArrayList<Registro>();
        IHidrometroDAO hidrometrodao = new HidrometroDAO();
        
        return hidrometrodao.listar();
    }
}
