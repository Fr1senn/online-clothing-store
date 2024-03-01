import { Product } from './product';
import { User } from './user';

export type WishList = {
  id: number;
  userId: number;
  productId: number;

  user: User;
  product: Product;
};
