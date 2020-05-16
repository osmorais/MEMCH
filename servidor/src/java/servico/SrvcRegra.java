/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import dao.InterfaceDAO.IRegraDAO;
import dao.RegraDAO;
import java.util.ArrayList;
import modelo.Regra;

/**
 *
 * @author osmar
 */
public class SrvcRegra {
    public static ArrayList<Regra> listar(){
        
        //ArrayList<Registro> arrdepartamento = new ArrayList<Registro>();
        IRegraDAO regradao = new RegraDAO();
        
        return regradao.listar();
    }
    public static Regra remover(Regra regra){

        IRegraDAO regradao = new RegraDAO();
        regradao.remover(regra);
        
        return regra;
    }
}
