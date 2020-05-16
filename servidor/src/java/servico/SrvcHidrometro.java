/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servico;

import dao.HidrometroDAO;
import dao.InterfaceDAO.IHidrometroDAO;
import modelo.Hidrometro;



/**
 *
 * @author osmar
 */
public class SrvcHidrometro {
    public static Hidrometro cadastrar(Hidrometro hidrometro){

        IHidrometroDAO hidrometrodao = new HidrometroDAO();
        hidrometro = hidrometrodao.cadastrar(hidrometro);
        
        return hidrometro;
    }
}
