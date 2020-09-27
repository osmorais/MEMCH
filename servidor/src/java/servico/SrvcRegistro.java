/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import dao.InterfaceDAO.IRegistroDAO;
import dao.RegistroDAO;
import java.util.ArrayList;
import modelo.Hidrometro;
import modelo.Registro;

/**
 *
 * @author osmar
 */
public class SrvcRegistro {
    public static ArrayList<Registro> listar(int hidrometroID){
        
        IRegistroDAO registrodao = new RegistroDAO();
        Hidrometro obj = new Hidrometro();
        obj.setId(hidrometroID);
        
        return registrodao.listar(obj);
    }
}
