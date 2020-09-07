/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { RegraService } from './regra.service';

describe('Service: Regra', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [RegraService]
    });
  });

  it('should ...', inject([RegraService], (service: RegraService) => {
    expect(service).toBeTruthy();
  }));
});
