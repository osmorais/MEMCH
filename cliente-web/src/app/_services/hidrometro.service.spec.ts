/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { HidrometroService } from './hidrometro.service';

describe('Service: Hidrometro', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [HidrometroService]
    });
  });

  it('should ...', inject([HidrometroService], (service: HidrometroService) => {
    expect(service).toBeTruthy();
  }));
});
