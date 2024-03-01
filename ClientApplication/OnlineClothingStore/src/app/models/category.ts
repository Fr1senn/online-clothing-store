import { Product } from './product';

export type Category = {
  id: number;
  title: string;

  products: Product[];
};
