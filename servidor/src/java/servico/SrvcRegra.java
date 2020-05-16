/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import dao.IRegraDAO;
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
    public static Regra cadastrar(Regra regra){

        IRegraDAO regradao = new RegraDAO();
        regra = regradao.cadastrar(regra);
        
        return regra;
    }
}
