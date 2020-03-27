/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import java.util.ArrayList;
import modelo.Registro;

/**
 *
 * @author osmar
 */
public interface IRegistroDAO {
    void cadastrar(Registro registro);
    void consultar(Registro registro);
    void alterar(Registro registro);
    void remover(Registro registro);
    ArrayList<Registro> listar();
}
