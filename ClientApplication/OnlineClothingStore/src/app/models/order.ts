import { OrderItem } from './orderItem';
import { Status } from './status';
import { User } from './user';

export type Order = {
  id: number;
  orderdate: Date;
  statusId: number;
  userId: number;

  status: Status;
  user?: User;

  orderItems: OrderItem[];
};
