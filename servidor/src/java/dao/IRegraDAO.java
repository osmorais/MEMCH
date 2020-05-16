/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import java.util.ArrayList;
import modelo.Regra;

/**
 *
 * @author pi
 */
public interface IRegraDAO {
    Regra cadastrar(Regra regra);
    void consultar(Regra regra);
    Regra alterar(Regra regra);
    void remover(Regra regra);
    ArrayList<Regra> listar();
}
