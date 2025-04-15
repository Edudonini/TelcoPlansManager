export interface Plano {
  id: number;
  nome: string;
  preco: number;
  limiteDados: number;
  limiteMinutos: number;
  limiteSMS: number;
  isAtivo: boolean;
  createdAt: Date;
  updatedAt: Date;
} 