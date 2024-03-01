import { Order } from "./order";

export type Status = {
  id: number;
  title: string;

  orders: Order[];
};
