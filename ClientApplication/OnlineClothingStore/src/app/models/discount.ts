import { Product } from './product';

export type Discount = {
  id: number;
  percentage: number;
  begin_date: Date;
  end_date: Date;
  is_active: boolean;

  products: Product[];
};
