/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import java.util.ArrayList;
import modelo.RegraTipo;

/**
 *
 * @author osmar
 */
public interface IRegraTipoDAO {
    void cadastrar(RegraTipo regraTipo);
    void consultar(RegraTipo regraTipo);
    void alterar(RegraTipo regraTipo);
    void remover(RegraTipo regraTipo);
    //ArrayList<RegraTipo> listar();
}
