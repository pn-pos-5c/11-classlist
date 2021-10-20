export default interface Student {
  id: number;
  gender: string;
  firstname: string;
  lastname: string;
  email: string;
  country: string;
  age: number;
  registered: boolean;
  clazzId: number | undefined;
}
