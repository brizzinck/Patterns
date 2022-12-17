﻿namespace AbstractFactoryBL.BaseAbstractFactory
{
	/// <summary>
	/// Первая конкретная фабрика.
	/// Определяет семейство продуктов.
	/// </summary>
	public class ConcreteFactory1 : IAbstractFactory
	{
		/// <summary>
		/// Создание первого конкретного продукта первого вида. 
		/// При этом возвращается первый абстрактный продукт,
		/// но конфигурация фабрики точно определяет, 
		/// какой именно это будет продукт (первый вид).
		/// По сути - это фабричный метод.
		/// </summary>
		/// <returns> Первый конкретный продукт первого вида. </returns>
		public IAbstractProductA CreateProductA()
		{
			// Здесь могут быть дополнительные действия.
			return new ConcreteProductA1();
		}

		/// <summary>
		/// Создание второго конкретного продукта первого вида. 
		/// При этом возвращается второй абстрактный продукт,
		/// но конфигурация фабрики точно определяет, 
		/// какой именно это будет продукт (первый вид).
		/// По сути - это фабричный метод.
		/// </summary>
		/// <returns> Второй конкретный продукт первого вида. </returns>
		public IAbstractProductB CreateProductB()
		{
			// Здесь могут быть дополнительные действия.
			return new ConcreteProductB1();
		}
	}
}
