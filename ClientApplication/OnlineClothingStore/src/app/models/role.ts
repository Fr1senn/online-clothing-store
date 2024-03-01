import { User } from "./user";

export type Role = {
  id: number;
  title: string;

  users: User[];
};
