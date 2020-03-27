/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import java.util.ArrayList;
import modelo.Hidrometro;

/**
 *
 * @author osmar
 */
public interface IHidrometroDAO {
    void cadastrar(Hidrometro hidrometro);
    void consultar(Hidrometro hidrometro);
    void alterar(Hidrometro hidrometro);
    void remover(Hidrometro hidrometro);
    ArrayList<Hidrometro> listar();
}
