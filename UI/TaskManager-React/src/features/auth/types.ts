export type ResponseStatus= "Sucess" | "Error" | "NotFound" | "CriticalError";

export interface LoginRequest 
{
  email: string;
  password: string;
}

export interface ResponsePattern
{
  Message?: string;
  Status: ResponseStatus;
  Content: string
}