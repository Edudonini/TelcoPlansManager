export interface Cliente {
  id: number;
  nome: string;
  cpf: string;
  email: string;
  telefone: string;
  endereco: string;
  dataNascimento: Date;
  isAtivo: boolean;
  createdAt: Date;
  updatedAt: Date;
} 