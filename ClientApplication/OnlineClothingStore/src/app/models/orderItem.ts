import { Order } from './order';
import { Product } from './product';

export type OrderItem = {
  id: number;
  quantity: number;
  priceAtOrder: number;
  orderId: number;
  productId: number;

  order: Order;
  product: Product;
};
