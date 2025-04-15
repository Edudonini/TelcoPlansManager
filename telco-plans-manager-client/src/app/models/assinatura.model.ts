import { Cliente } from './cliente.model';
import { Plano } from './plano.model';

export interface Assinatura {
  id: number;
  clienteId: number;
  planoId: number;
  dataInicio: Date;
  dataFim: Date;
  isAtiva: boolean;
  createdAt: Date;
  updatedAt: Date;
  cliente?: Cliente;
  plano?: Plano;
} 