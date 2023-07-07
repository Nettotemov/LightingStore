using Microsoft.EntityFrameworkCore;

namespace LampStore.Models
{
	public class EFOrderRepository : IOrderRepository
	{
		private readonly StoreDbContext context;

		public EFOrderRepository(StoreDbContext ctx)
		{
			context = ctx;
		}
		public IQueryable<Order> Orders => context.Orders.Include(o => o.Lines).ThenInclude(l => l.Product);

		public void CreateOrder(Order order)
		{
			context.SaveChanges();
		}

		public void SaveOrder(Order order)
		{
			context.AttachRange(order.Lines.Select(l => l.Product));
			if (order.OrderID == 0)
			{
				context.Orders.Add(order);
			}
			context.SaveChanges();
		}
	}
}