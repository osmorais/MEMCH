/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import dao.InterfaceDAO.IRegraTipoDAO;
import dao.RegraTipoDAO;
import java.util.ArrayList;
import modelo.RegraTipo;

/**
 *
 * @author osmar
 */
public class SrvcRegraTipo {
    public static ArrayList<RegraTipo> listar(){
        
        //ArrayList<Registro> arrdepartamento = new ArrayList<Registro>();
        IRegraTipoDAO regratipodao = new RegraTipoDAO();
        
        return regratipodao.listar();
    }
}
