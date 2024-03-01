import { Product } from "./product";

export type Manufacturer = {
  id: number;
  title: string;

  products: Product[];
};
