import { Category } from './category';
import { Discount } from './discount';
import { Manufacturer } from './manufacturer';
import { OrderItem } from './orderItem';
import { Review } from './review';
import { WishList } from './wishList';

export type Product = {
  id: number;
  title: string;
  price: number;
  rating?: number;
  manufacturerId?: number;
  categoryId?: number;
  discountId?: number;

  category?: Category;
  manufacturer?: Manufacturer;
  discount?: Discount;

  orderItems: OrderItem[];
  reviews: Review[];
  wishList: WishList[];
};
