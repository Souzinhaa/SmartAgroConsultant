# Exemplo de uso Json-Server
## _Para Rodar_

## Console do Node
```sh
cd apiMock
npm install
npm run start
```
## Navegador
```sh
http://localhost:3001/
```

> OBS.: Todos os end-points estarão visíveis, sendo possível realizar `GET, POST, PUT e DELETE`.

## Tabelas
Tabela `usuario`:
| Atributo | Tipo |
| ------ | ------ |
| nome | string |
| senha | string|
| login | string|
| email | string|
| token | uuid|
| visibilidade | bool|

Tabela `produto_fazenda`:
| Atributo | Tipo |
| ------ | ------ |
| uuid_usuario | uuid |
| plantas |  []Planta |
| tamanho_hectares |  Double |
| tipo_solo | int |
| localizacao | String(coordenada google maps) |

Tabela `tipo_solo`:
| Atributo | Tipo |
| ------ | ------ |
| id | int |
| nome | String |
| descricao | String |

Tabela `historico_fazenda_usuario`:
| Atributo | Tipo |
| ------ | ------ |
| uuid_usuario | uuid |
| data_inicio_plantacao | Long |
| data_fim_plantacao | Long |
| planta | Planta |


Tabela `planta`:
| Atributo | Tipo |
| ------ | ------ |
| cod_planta | Int |
| nome | String |
| descricao | String  |

