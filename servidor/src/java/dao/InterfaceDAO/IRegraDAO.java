/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao.InterfaceDAO;

import java.util.ArrayList;
import modelo.Hidrometro;
import modelo.Regra;

/**
 *
 * @author pi
 */
public interface IRegraDAO {
    void cadastrar(Regra regra, Hidrometro hidrometro);
    void consultar(Regra regra);
    void alterar(Regra regra, Hidrometro hidrometro);
    void remover(Regra regra);
    ArrayList<Regra> listar();
}
