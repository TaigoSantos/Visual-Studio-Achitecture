# (PoC) Unit of Work

Projeto de uma prova de conceito do pattern Unit of Work, constru�do com a tecnologia.

## Tecnologias de Desenvolvimento

[tec-1]: https://github.com/dotnet
[tec-2]: https://github.com/dotnet/csharplang
[tec-3]: https://github.com/aspnet/EntityFramework6
[tec-4]: https://simpleinjector.org

* [.NET Framrwork 4.6.x][tec-1]
* [.NET Framrwork C# 7.x][tec-2]
* [Entity Framework 6.x][tec-3]
* [Simple Injector 4.x][tec-4]


## Refer�ncias de Estudos

[ref-1]: https://martinfowler.com/eaaCatalog/unitOfWork.html
[ref-2]: https://www.youtube.com/watch?v=4nqL31Qti_M
[ref-3]: https://www.youtube.com/watch?v=SRIiWg_yY4I&t=973s
[ref-4]: https://www.youtube.com/watch?v=Da_bGoUlITQ
[ref-5]: https://www.youtube.com/watch?v=08mLfQHlbik
[ref-6]: https://github.com/DenisBiondic/ScopedUnitOfWork
[ref-7]: http://mehdi.me/ambient-dbcontext-in-ef6
[ref-8]: https://www.cuttingedge.it/blogs/steven/pivot/entry.php?id=100

* [Unit Of Work][ref-1] - Descri��o do Pattern.
* [Unit Of Work - PARTE 1][ref-2] - V�deo tutorial sobre Unit of Work (Parte 1).
* [Unit Of Work - PARTE 2][ref-3] - V�deo tutorial sobre Unit of Work (Parte 2).
* [IoC e DI][ref-4] - V�deo tutorial sobre inje��o de depend�ncia e invers�o de controle.
* [SOLID - Interface Segregation Principle][ref-5] - V�deo tutorial sobre o princ�pio de segrega��o de interface.
* [ScopedUnitOfWork][ref-6] - Reposit�rio contendo um projeto completo sobre Scoped Context.
* [Managing DbContext the right way][ref-7] - Artigo descrevendo o modo correto de utilizar um contexto no Entity Framework
* [Abstract Factories are a code smell][ref-8] - Artigo explicando que Abstract Factories s�o "code smell".


## Considera��es

* O artigo [Abstract Factories are a code smell][ref-1] dis que a utiliza��o de abstract factories n�o � uma boa pr�tica de programa��o, sendo assim foi substitu�da a classe `IUnitOfWorkFactory` pela depend�ncia `Func<IUnitofWorkContextAware>`.
* Ao inv�s de _Ninject_ utilizada no tutorial [Unit Of Work - PARTE 1][ref-2] e [Unit Of Work - PARTE 2][ref-3], foi usada a tecnologia [Simple Injector][tec-4].

## Autores

* **Tiago Felipe dos Santos** - [Github](https://github.com/taigosantos) - [Linkedin](https://www.linkedin.com/in/tiago-santos-36b25341/)