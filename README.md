# SoftwareAnalytic - Backend
O backend consiste em prover classes e a implementação do algoritmo de análise do código em blocos.
# Classe Block
A classe Block provê todas funcionalidades que serão necessárias para o usuário criar o código e efetuar sua analise.
Ela pode ser usada diretamente na parte visual, mas é recomendado utilizar a classe Core para isso.
## BlockType
O enum <b>BlockType</b> é utilizado para identificar o tipo de bloco que está sendo analisado pelo algoritmo e/ou utilizado pelo usuário.
são eles: <i>INICIO = 0, SE = 1, SE_NAO = 2, LOOP = 3, AUX = 4</i>.
Com excessão do bloco AUX que é utilizado apenas na análise do algoritmo e não está disponivel para o usuário.
## Atributos
``` csharp
//Guarda o tipo do bloco.
public BlockType type

//Armazena uma lista de instruções pertencentes ao bloco.
private List<Instruction> instructions

//Armazena uma lista de blocos "filhos" do bloco.
private List<Block> childBlocks

//Guarda o bloco "mãe-pai"
public Block motherBlock

//Id do bloco
public int id

//Se caso o bloco for do tipo LOOP, esse atributo irá armazenar o numero de iterações do LOOP.
private int loopIt

//Complexidade do bloco
public int blockComplexity

//Adiciona uma instrução ao bloco.
public void AddInstruction(Instruction op)

//Remove uma instrução do bloco.
public void RemoveInstruction(Instruction op)

//Adiciona um bloco filho ao bloco.
public void AddChildBlock(Block n_block)

//Remove o "b_toBeRemoved" da lista de filhos.
public void RemoveChildBlock(Block b_toBeRemoved)

//Retorna todos os blocos filhos.
public List<Block> GetChildBlocks()

//Retorna todas as instruções do bloco.
public List<Instruction> GetInstructions()

```

# Classe Core
A classe Core será chamada pelo programa principal para manipular os blocos e retornar informações sobre eles.
```csharp
//Bloco principal ou Bloco Cabeça.
public Block mainBlock;

//Lista com todos os blocos criados
public List<Block> allBlocks;

//Cria um bloco de condição
public Block CreateCondBlock(BlockType type, Block parent);

//Cria um bloco de loop aonde o itControl é o numero de iterações
public Block CreateLoopBlock(BlockType, Block parent, int itControl);

//Cria o bloco principal "mainblock"
public void CreateMainBlock()

//Retorna o numero de iterações do bloco, caso seja um bloco de loop
public int GetLoopItSize()

//Retorna todos os blocos de loop contido na lista de blocos passada como parametro
public List<Block> GetLoopBlocks(List<Block> blocks);

//Retorna o numero de instruções contidas no bloco passado como parametro
public int GetInstrCount(Block b);

//Retorna os blocos de condição contidos na lista de blocos passada como parametro
public List<Block> GetCondBlocks(List<Block> blocks);

//Retorna o nivel da hierarquia do bloco passado como parametro
public int getHierarchOfBlock(Block parent)


```
