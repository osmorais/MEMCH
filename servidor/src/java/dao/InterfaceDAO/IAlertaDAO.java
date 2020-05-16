/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao.InterfaceDAO;

import java.util.ArrayList;
import modelo.Alerta;

/**
 *
 * @author pi
 */
public interface IAlertaDAO {
    void cadastrar(Alerta alerta);
    void consultar(Alerta alerta);
    void alterar(Alerta alerta);
    void remover(Alerta alerta);
    ArrayList<Alerta> listar();
}
