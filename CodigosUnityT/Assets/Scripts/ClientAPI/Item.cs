using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int ItemID;
    public string Nome;
    public int Idade;

    //public int ItemID
    //{
    //    get
    //    { return _itemID; }
    //    set { _itemID = value; }
    //}

    //public string Nome
    //{
    //    get { return nome; }
    //    set { nome = value; }
    //}

    //public string Descricao
    //{
    //    get { return _descricao; }
    //    set { _descricao = value; }
    //}

    public string Descricao;
    /*{
        get { return raridade; }
        set { raridade = value; }
    }*/

    public string Origem;
   /* {
        get { return danoMaximo; }
        set { danoMaximo = value; }
    }*/

    public int TipoItemID;
   /* {
        get { return tipoItemID; }
        set { tipoItemID = value; }
    }*/

    //private TipoItem _tipoItem;

    //public TipoItem _TipoItem
    //{
    //    get { return _tipoItem; }
    //    set { _tipoItem = value; }
    //}
}
