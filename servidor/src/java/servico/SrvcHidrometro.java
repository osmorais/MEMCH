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
import modelo.Regra;



/**
 *
 * @author osmar
 */
public class SrvcHidrometro {
    public static Hidrometro cadastrar(Hidrometro hidrometro){

        IHidrometroDAO hidrometrodao = new HidrometroDAO();
        if(hidrometro.getIdentificador() != null ||
           hidrometro.getChave() != null ||
           hidrometro.getModelo() != null ||
           hidrometro.getDescricao()!= null){
            hidrometrodao.cadastrar(hidrometro);
        }
        
        for(Regra regra : hidrometro.getRegras()){
            IRegraDAO regradao = new RegraDAO();
            regradao.cadastrar(regra, hidrometro);
        }
        
        return hidrometro;
    }
    
    public static Hidrometro consultar(Hidrometro hidrometro){

        IHidrometroDAO hidrometrodao = new HidrometroDAO();
        hidrometrodao.consultar(hidrometro);
                
        IRegistroDAO registrodao = new RegistroDAO();
        hidrometro.setRegistros(registrodao.listar(hidrometro)); 
                
        IAlertaDAO alertadao = new AlertaDAO();
        hidrometro.setAlertas(alertadao.listar(hidrometro)); 
                
        IRegraDAO regradao = new RegraDAO();
        hidrometro.setRegras(regradao.listar(hidrometro)); 
        
        return hidrometro;
    }
    
    public static Hidrometro alterar(Hidrometro hidrometro){

        IHidrometroDAO hidrometrodao = new HidrometroDAO();
        if(hidrometro.getIdentificador() != null ||
           hidrometro.getChave() != null ||
           hidrometro.getModelo() != null ||
           hidrometro.getDescricao()!= null){
            hidrometrodao.alterar(hidrometro);
        }
        
        for(Regra regra : hidrometro.getRegras()){
            IRegraDAO regradao = new RegraDAO();
            regradao.alterar(regra, hidrometro);
        }
        
        return hidrometro;
    }
    
    public static ArrayList<Hidrometro> listar(){
        
        //ArrayList<Registro> arrdepartamento = new ArrayList<Registro>();
        IHidrometroDAO hidrometrodao = new HidrometroDAO();
        
        return hidrometrodao.listar();
    }
}
