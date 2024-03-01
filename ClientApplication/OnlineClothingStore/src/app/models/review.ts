import { Product } from './product';
import { User } from './user';

export type Review = {
  id: number;
  comment?: string;
  reviewDate: Date;
  rating?: number;
  userId?: number;
  productId?: number;

  product?: Product;
  user?: User;
};
