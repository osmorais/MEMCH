/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import dao.IRegistroDAO;
import dao.RegistroDAO;
import java.util.ArrayList;
import modelo.Registro;

/**
 *
 * @author osmar
 */
public class SrvcRegistro {
    public static ArrayList<Registro> listar(){
        
        //ArrayList<Registro> arrdepartamento = new ArrayList<Registro>();
        IRegistroDAO registrodao = new RegistroDAO();
        
        return registrodao.listar();
    }
}
