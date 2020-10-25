/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ConexaoService } from './conexao.service';

describe('Service: Conexao', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ConexaoService]
    });
  });

  it('should ...', inject([ConexaoService], (service: ConexaoService) => {
    expect(service).toBeTruthy();
  }));
});
