import { Order } from './order';
import { Review } from './review';
import { Role } from './role';
import { WishList } from './wishList';

export type User = {
  id: number;
  firstName: string;
  lastName: string;
  email: string;
  address: string;
  hashedPassword: string;
  birthDate: Date;
  registrationDate: Date;
  roleId: number;

  role: Role;

  orders: Order[];
  reviews: Review[];
  wishList: WishList[];
};
