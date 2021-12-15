using System;

namespace Stack
{
    public class Pilha{
        Posicao topo;
        
        public object Empilha(object item){
            topo = new Posicao(topo, item); 

            return item;
        }

        public object Desempilha(){
            if (topo == null){
                throw new InvalidOperationException();
            }

            object resultado = topo.item;
            topo = topo.itemDebaixo;

            return resultado;
        }

        class Posicao
        {
            public Posicao itemDebaixo;

            public object item;

            public Posicao(Posicao itemDebaixo, object item){
                this.itemDebaixo = itemDebaixo;
                this.item = item;
            }
        }
    }
}
