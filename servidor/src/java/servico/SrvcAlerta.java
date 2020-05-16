/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import dao.InterfaceDAO.IAlertaDAO;
import dao.AlertaDAO;
import java.util.ArrayList;
import modelo.Alerta;

/**
 *
 * @author pi
 */
public class SrvcAlerta {
    public static ArrayList<Alerta> listar(){
        
        //ArrayList<Registro> arrdepartamento = new ArrayList<Registro>();
        IAlertaDAO alertadao = new AlertaDAO();
        
        return alertadao.listar();
    }
}
