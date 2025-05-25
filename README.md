# CarbonTrackerAPI - API REST para Gestão de Emissões

*Projeto desenvolvido para fins acadêmicos.*

Aplicação Web Java com Spring Boot, cujo objetivo é disponibilizar uma *API RESTful* voltada à gestão de dados relacionados a emissões de carbono. 
A proposta não envolve cálculos diretos, mas sim a exposição segura de endpoints para operações CRUD, integrando-se a um banco de dados Oracle e aplicando práticas modernas de versionamento, segurança e persistência de dados.

---

## Objetivo

Desenvolver um serviço RESTful com foco em:

- Integração com banco de dados Oracle
- Segurança stateless com autenticação via JWT
- Validações robustas com Bean Validation
- Estruturação clara e escalável com JPA e Flyway

---

## Tecnologias e Conceitos Utilizados

- **Java + Spring Boot**
- **Spring Web + Spring Security + JWT**
- **Spring Data JPA + JDBC + JPQL**
- **Flyway** para versionamento do schema do banco
- **Oracle Database**
- **Lombok** para redução de código repetitivo
- **Bean Validation**

---

## Funcionalidades Principais

- A API expõe um conjunto de endpoints organizados e seguros que permitem:
  - **Criação**
  - **Consulta**
  - **Atualização**
  - **Exclusão**
- Autenticação e autorização via **JWT**
- Validação automática de dados recebidos
- Controle de versão do banco com **Flyway**
- Persistência com **JPA (Hibernate)** e uso de **JPQL**
